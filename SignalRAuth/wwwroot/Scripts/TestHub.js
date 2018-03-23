let connection = new signalR.HubConnection('http://localhost/SignalRAuth/test');
connection.start();

connection.on('send', function (username) {
    console.log('connected: ' + username);
    $('#connectStatus').text(username).change();
});