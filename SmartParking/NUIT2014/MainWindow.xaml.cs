using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Kinect;
using Microsoft.Speech.AudioFormat;
using Microsoft.Speech.Recognition;
using System.Net.Sockets;
using System.Speech.Synthesis;
using System.Threading;
using System.Net.Mail;
using System.Diagnostics;



namespace NUIT2014
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 


    public partial class MainWindow : Window
    {
        //recongition
        SpeechRecognitionEngine recognizer;
        KinectSensor sensor;
        SpeechSynthesizer sSynth = new SpeechSynthesizer();

        //checking the "state"
        bool helloSaid;
        bool infoCorrect;
        bool infoSaid;

        //making the order
        string order = "a";
        string orderSpeech = "";

        GrammarBuilder wakerC = new GrammarBuilder();
        Grammar wakingCommand;

        GrammarBuilder numbersC = new GrammarBuilder();
        Grammar mainCommand;

        GrammarBuilder selection = new GrammarBuilder();
        Grammar yesNoCommand;

        SmartParkingWebSocketServer SS;

        Dictionary<string, string> userBase = new Dictionary<string, string>();

        public MainWindow()
        {
            InitializeComponent();
            userBase.Add("BCD-234", "Kalle Rantanen");
            userBase.Add("EOF-365", "Seppo Laitela");
            userBase.Add("135-AMB", "Andrei Kipolpowich");
            userBase.Add("HNL-317", "Laszlo Nagy");
            CancelBtn.Visibility = System.Windows.Visibility.Hidden;

            SS = new SmartParkingWebSocketServer(50000);
           // Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe",
           //   "file:///C:/Users/wahlkri2/Desktop/smart/qrtest.html");

            ProcessStartInfo proc = new ProcessStartInfo("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe");
            proc.Arguments = "--allow-file-access-from-files" + " " + "file:///C:/Users/wahlkri2/Desktop/smart/index.html";
            Process.Start(proc);



            foreach (var potentialSensor in KinectSensor.KinectSensors)
            {
                if (potentialSensor.Status == KinectStatus.Connected)
                {
                    sensor = potentialSensor;
                    break;
                }
            }


            try
            {
                sensor.Start();
                sensor.Stop();
                sensor.AudioSource.AutomaticGainControlEnabled = true;
                sensor.AudioSource.EchoCancellationMode = EchoCancellationMode.CancellationAndSuppression;
                sensor.AudioSource.NoiseSuppression = true;
                sensor.AudioSource.BeamAngleMode = BeamAngleMode.Adaptive;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message + Environment.NewLine + "Kinect not probably connected. Will use default input.");
                
            }


            //sensor.AudioSource.AutomaticGainControlEnabled = true;
            //sensor.AudioSource.EchoCancellationMode = EchoCancellationMode.CancellationAndSuppression;
            //sensor.AudioSource.NoiseSuppression = true;
            //sensor.AudioSource.BeamAngleMode = BeamAngleMode.Adaptive;


            sSynth.SetOutputToDefaultAudioDevice();
            sSynth.SelectVoiceByHints(VoiceGender.Male);
            sSynth.Volume = 100;





            recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));



            Choices numbers = new Choices();
            numbers.Add(new SemanticResultValue("zero", "0"));
            numbers.Add(new SemanticResultValue("one", "1"));
            numbers.Add(new SemanticResultValue("two", "2"));
            numbers.Add(new SemanticResultValue("three", "3"));
            numbers.Add(new SemanticResultValue("four", "4"));
            numbers.Add(new SemanticResultValue("five", "5"));
            numbers.Add(new SemanticResultValue("six", "6"));
            numbers.Add(new SemanticResultValue("seven", "7"));
            numbers.Add(new SemanticResultValue("eight", "8"));
            numbers.Add(new SemanticResultValue("nine", "9"));
            numbers.Add(new SemanticResultValue("ten", "10"));
            numbers.Add(new SemanticResultValue("eleven", "11"));
            numbers.Add(new SemanticResultValue("twelve", "12"));


            Choices letters = new Choices(new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" });
            Choices dayTime = new Choices(new string[] { "am", "pm" });
            Choices yesNo = new Choices(new string[] { "yes", "no" });
            Choices startUp = new Choices(new string[] { "arrive at", "be there", "pick the car" });
            Choices wrongThing = new Choices(new string[] { "time", "license number" });

            GrammarBuilder wrongC = new GrammarBuilder();
            wrongC.AppendWildcard();
            wrongC.Append(new SemanticResultKey("Choise", wrongThing));

            //GrammarBuilder wakerC = new GrammarBuilder();
            wakerC.Culture = new System.Globalization.CultureInfo("en-US");
            wakerC.AppendWildcard();
            wakerC.Append(new SemanticResultKey("Travis", "travis"));
            wakerC.AppendWildcard();

            //GrammarBuilder numbersC = new GrammarBuilder();
            numbersC.Culture = new System.Globalization.CultureInfo("en-US");
            numbersC.Append("I will");
            numbersC.Append(new SemanticResultKey("Start up", startUp));
            numbersC.Append(new SemanticResultKey("Number", numbers));
            numbersC.Append(new SemanticResultKey("Time", dayTime));
            numbersC.AppendWildcard();
            numbersC.Append("license number");
            numbersC.AppendWildcard();
            numbersC.Append(new SemanticResultKey("Number1", letters));
            numbersC.Append(new SemanticResultKey("Number2", letters));
            numbersC.Append(new SemanticResultKey("Number3", letters));
            numbersC.AppendWildcard();
            numbersC.Append(new SemanticResultKey("Number4", numbers));
            numbersC.Append(new SemanticResultKey("Number5", numbers));
            numbersC.Append(new SemanticResultKey("Number6", numbers));


            //GrammarBuilder selection = new GrammarBuilder();
            selection.Culture = new System.Globalization.CultureInfo("en-US");
            selection.Append(new SemanticResultKey("Valid", yesNo));
            selection.AppendWildcard();



            //Choices bothg = new Choices(new GrammarBuilder[] { numbersC, wakerC, selection });
            //GrammarBuilder bf = new GrammarBuilder(bothg);
            //bf.Culture = new System.Globalization.CultureInfo("en-US");

            //Grammar g = new Grammar(bf);
            //g.Name = ("Ordering");
            //recognizer.LoadGrammarAsync(g);

            wakingCommand = new Grammar(wakerC);
            wakingCommand.Name = ("Waking the system");
            recognizer.LoadGrammarAsync(wakingCommand);

            mainCommand = new Grammar(numbersC);
            mainCommand.Name = "Making the order";

            yesNoCommand = new Grammar(yesNo);
            yesNoCommand.Name = "Making the validation";

            recognizer.AudioLevelUpdated += recognizer_AudioLevelUpdated;
            recognizer.SpeechRecognized += recognizer_SpeechRecognized;
            recognizer.SpeechRecognitionRejected += recognizer_SpeechRecognitionRejected;
            recognizer.AudioSignalProblemOccurred += recognizer_AudioSignalProblemOccurred;


            helloSaid = true;
            recognizer.UnloadAllGrammars();
            recognizer.LoadGrammarAsync(mainCommand);


            Thread.Sleep(15000);

            debugLog.Text = "";
            recognizer.SetInputToWaveFile("C:\\Users\\wahlkri2\\Desktop\\NUIT2014\\bin\\Debug\\test.wav");
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
            sSynth.Speak("Welcome to use Travis 0 point 0 0 1");


        }

        void recognizer_AudioSignalProblemOccurred(object sender, AudioSignalProblemOccurredEventArgs e)
        {
            Console.WriteLine(e.AudioSignalProblem.ToString());


        }

        private void recognizer_SpeechRecognitionRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {

            //Console.WriteLine(e.Result.Text + " " + e.Result.Semantics.Confidence);

            //string[] feedback = new string[] {"Sorry, I didn't understand that", "Can you repeat that?",
            //    "I didn't quite catch that", "I couldn't get what you were saying", "Your speech was unclear, please repeat"};


            //recognizer.RequestRecognizerUpdate();
            //sSynth.Speak(feedback[new Random().Next(0, feedback.Length - 1)]);
            //Thread.Sleep(1000);


        }

        void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Semantics.Confidence < 0.2)
                return;

            debugLog.Text = e.Result.Text;


            if (e.Result.Text.Contains("yes") && infoSaid && e.Result.Semantics.Confidence > 0.25f && !infoCorrect)
            {
                string[] slots = new string[] { "A-121", "C-124", "A-172", "F-412", "G-125", "W-152", "P-125", "E-151", "X-121", "A-122", "A-1", "C-25", "E-15", "G-125", "F-122", "G-11" };
                string signedSLot = slots[new Random().Next(0, slots.Length - 1)];
                recognizer.RequestRecognizerUpdate();
                try
                {
                    string licNum = new dataBuilder().buildDataLicense(order);
                    sSynth.Speak("Good day mister " + userBase[licNum] + ". Your car will be at the slot " + signedSLot + " and you will receive the QR-code to your browser. Have a nice day.");
                }
                catch (Exception ex)
                {
                    sSynth.Speak("Your car will be at the slot " + signedSLot + " and you will receive the QR-code to your browser. Have a nice day.");
                }


                string dataString = new dataBuilder().buildDataLicense(order) + "|" + new dataBuilder().buildDataTime(order) + "|" + signedSLot;
                SS.SendMessage(dataString, 1);
                //MessageBox.Show(dataString);
                infoCorrect = true;
                Button_Click_1(this, null);
                Thread.Sleep(5000);

            }

            if (e.Result.Text.Contains("no") && infoSaid && e.Result.Semantics.Confidence > 0.6f && !infoCorrect)
            {
                recognizer.RequestRecognizerUpdate();
                sSynth.Speak("Give details again");
                infoSaid = false;
                recognizer.UnloadGrammar(yesNoCommand);
                recognizer.LoadGrammarAsync(mainCommand);
                Thread.Sleep(500);
            }



            consoleLog.Text += e.Result.Text + " " + e.Result.Semantics.Confidence + Environment.NewLine;

            if (sensor != null)
            {
                consoleLog.Text += "Sensor confidence: " + sensor.AudioSource.SoundSourceAngleConfidence + Environment.NewLine;
            }


            if (e.Result.Semantics.ContainsKey("Travis") && helloSaid && e.Result.Semantics.Confidence > 0.1f)
            {
                recognizer.RequestRecognizerUpdate();
                sSynth.Speak("Please give order");
                Thread.Sleep(2000);


            }


            
        
            



            if (e.Result.Semantics.ContainsKey("Number") && helloSaid && e.Result.Semantics.Confidence > 0.2f)
            {



                recognizer.UnloadGrammar(mainCommand);
                recognizer.LoadGrammarAsync(yesNoCommand);

                Console.WriteLine(e.Result.Semantics["Number1"].Value + " " + e.Result.Semantics["Number2"].Value);

                orderSpeech = "I will arrive at :" + e.Result.Semantics["Number"].Value + " " + e.Result.Semantics["Time"].Value + ", license number: " + e.Result.Semantics["Number1"].Value.ToString().ToUpper()
                    + " " + e.Result.Semantics["Number2"].Value.ToString().ToUpper() + " " + e.Result.Semantics["Number3"].Value.ToString().ToUpper() + " " + e.Result.Semantics["Number4"].Value + " " +
                    e.Result.Semantics["Number5"].Value + " " + e.Result.Semantics["Number6"].Value;

                order = "I will arrive at " + e.Result.Semantics["Number"].Value + " " + e.Result.Semantics["Time"].Value + ", license number: " + e.Result.Semantics["Number1"].Value.ToString().ToUpper()
                    + "" + e.Result.Semantics["Number2"].Value.ToString().ToUpper() + "" + e.Result.Semantics["Number3"].Value.ToString().ToUpper() + "-" + e.Result.Semantics["Number4"].Value + "" +
                    e.Result.Semantics["Number5"].Value + "" + e.Result.Semantics["Number6"].Value;

                string[] slots = new string[] { "A-121", "C-124", "A-172", "F-412", "G-125", "W-152", "P-125", "E-151", "X-121", "A-122", "A-1", "C-25", "E-15", "G-125", "F-122", "G-11" };
                string signedSLot = slots[new Random().Next(0, slots.Length - 1)];
                recognizer.RequestRecognizerUpdate();
                try
                {
                    string licNum = new dataBuilder().buildDataLicense(order);
                    sSynth.Speak("Good day mister " + userBase[licNum] + ". Your car will be at the slot " + signedSLot + " and you will receive the QR-code to your browser. Have a nice day.");
                }
                catch (Exception ex)
                {
                    sSynth.Speak("Your car will be at the slot " + signedSLot + " and you will receive the QR-code to your browser. Have a nice day.");
                }


                string dataString = new dataBuilder().buildDataLicense(order) + "|" + new dataBuilder().buildDataTime(order) + "|" + signedSLot;
                SS.SendMessage(dataString, 1);
                infoCorrect = true;
                Button_Click_1(this, null);
                Thread.Sleep(5000);
                infoSaid = true;
            }


        }


        void recognizer_AudioLevelUpdated(object sender, AudioLevelUpdatedEventArgs e)
        {
            Console.WriteLine("Audio level: "+e.AudioLevel.ToString());
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (sensor != null)
            {
                StartButton.Background = Brushes.Gray;
                debugLog.Text = "";
                sensor.Stop();
                recognizer.RecognizeAsyncStop();
                recognizer.UnloadAllGrammars();
                recognizer.LoadGrammarAsync(wakingCommand);
                helloSaid = false;
                infoCorrect = false;
                infoSaid = false;
            }
            else
            {
                StartButton.Background = Brushes.Gray;
                debugLog.Text = "";
                recognizer.RecognizeAsyncStop();
                recognizer.UnloadAllGrammars();
            
     
                infoCorrect = false;
                infoSaid = false;

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (sensor != null)
            {
                StartButton.Background = Brushes.Red;
                animationRed.Opacity = 0.5f;
                debugLog.Text = "";
                sensor.Stop();
                sensor.Start();
                recognizer.SetInputToAudioStream(sensor.AudioSource.Start(), new SpeechAudioFormatInfo(EncodingFormat.Pcm, 16000, 16, 1, 32000, 2, null));
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
                sSynth.Speak("Welcome to use Travis 0 point 0 0 1");
            }
            else
            {
                StartButton.Background = Brushes.Red;
                animationRed.Opacity = 0.5f;
                debugLog.Text = "";
                recognizer.SetInputToWaveFile("C:\\Users\\wahlkri2\\Desktop\\NUIT2014\\bin\\Debug\\test.wav");
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
                sSynth.Speak("Welcome to use Travis 0 point 0 0 1");

            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if(sensor!=null)
                sensor.Stop();
            this.Close();
        }

        private void animationRed_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            animationRed.Opacity += 0.1f;
        }




    }
}
