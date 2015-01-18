SmartParkingWebSocketClient.prototype.messageData = '';

function SmartParkingWebSocketClient(uri) {

    this.serverUri = uri;
    this.ws = new WebSocket(this.serverUri);
    this.ws.binaryType = "blob";

    var createQRCode = function (codeData) {
        jQuery("#qrcode").qrcode({
            render : "table",
            text : codeData
        });
    }

    this.ws.onopen = function(evt) {
        console.log("Websocket connection is open");
    }

    this.ws.onclose = function() {
        console.log("Websocket connection is closed");
    }

    this.ws.onerror = function(err) {
        console.log("Websocket error occurs! " + err);
    }

    this.ws.onmessage = function(msg) {
        var data = msg.data;
        console.log("Websocket receiving message from server: " + data);
        if (data) {
            createQRCode(data);
        } else {
            console.log("Websocket get empty data ... thats not ok man!");
        }
    }
};

SmartParkingWebSocketClient.prototype.disconnectWebSocket = function () {
    if (this.ws) {
        console.log("websocket will be closed now!!!!!!");
        this.ws.close();
    }
}

SmartParkingWebSocketClient.prototype.sendData = function (data) {
    if (data && this.ws) {
        console.log("data: " + data);
        this.ws.send(data);
    }
    else {
        console.log("Error no data recieved or WebSocket is not open");
    }
}
