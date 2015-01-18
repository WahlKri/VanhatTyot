var audio_context,
    recorder,
    url,
    volume,
    volumeLevel = 0,
    currentEditedSoundIndex;

function startUserMedia(stream) {
  var input = audio_context.createMediaStreamSource(stream);
  console.log('Media stream created.');

  volume = audio_context.createGainNode();
  volume.gain.value = volumeLevel;
  input.connect(volume);
  volume.connect(audio_context.destination);
  console.log('Input connected to audio context destination.');

  recorder = new Recorder(input);
  console.log('Recorder initialised.');
}

function changeVolume(value) {
  if (!volume) return;
  volumeLevel = value;
  volume.gain.value = value;
}

function startRecording(button) {
  recorder && recorder.record();
  button.disabled = true;
  button.nextElementSibling.disabled = false;
  console.log('Recording...');
}

function stopRecording(button) {
  recorder && recorder.stop();
  button.disabled = true;
  button.previousElementSibling.disabled = false;
  console.log('Stopped recording.');

  // create WAV download link using audio data blob
  createDownloadLink();
  recorder.clear();
}

function createDownloadLink() {
  currentEditedSoundIndex = -1;
  recorder && recorder.exportWAV(handleWAV.bind(this));
}

function handleWAV(blob) {
  //url = URL.createObjectURL(blob);
  console.log("size of blob object" + blob.size);
  /* sendWav(blob); */
}


function sendWav(data) {
  console.log("try to send: " + data);
  /* spwsc.sendData(data); */
}


window.onload = function init() {
  try {
    // webkit shim
    window.AudioContext = window.AudioContext || window.webkitAudioContext || window.mozAudioContext;
    navigator.getUserMedia = navigator.getUserMedia || navigator.webkitGetUserMedia || navigator.mozGetUserMedia;
    window.URL = window.URL || window.webkitURL || window.mozURL;

    audio_context = new AudioContext();
    spwsc = new SmartParkingWebSocketClient("ws://localhost:50000");
    console.log('Audio context set up.');
    console.log('navigator.getUserMedia ' + (navigator.getUserMedia ? 'available.' : 'not present!'));
  } catch (e) {
    console.warn('No web audio support in this browser!');
  }
  navigator.getUserMedia({audio: true}, startUserMedia, function(e) {
    console.warn('No live audio input: ' + e);
  });
};
