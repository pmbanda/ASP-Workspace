// Initialize Firebase
var config = {
    apiKey: "AIzaSyDeZf199WjBhIzX_Pn510M1kF5eTlzMZXs",
    authDomain: "resumejson.firebaseapp.com",
    databaseURL: "https://resumejson.firebaseio.com",
    projectId: "resumejson",
    storageBucket: "resumejson.appspot.com",
    messagingSenderId: "81316327702"

};
var app = firebase.initializeApp(config)

window.onload = function () {
    // obtain reference to the firebase database
    var database = app.database()
    console.log(`Database Obtained...`)

    // obtain reference to the button
    var btnResume = document.getElementById("btnResume")
    console.log(`Button Reference Obtained...`)

    btnResume.addEventListener('click', event => {
        console.log(`Event Listener added`)
    });

};
