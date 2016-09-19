/* eslint-env browser */
;(function () {
  'use strict'

  document.getElementById('get-location-btn').addEventListener('click', geoFindMe)

  function geoFindMe () {
    var output = document.getElementById('container')

    if (!navigator.geolocation) {
      output.innerHTML = '<p>Geolocation is not supported by your browser</p>'
      return
    }

    let promise = new Promise((resolve, reject) => {
      navigator.geolocation.getCurrentPosition(resolve, reject)
    })
      .then(success)
      .catch(error)

    function success (position) {
      var latitude = position.coords.latitude
      var longitude = position.coords.longitude

      output.innerHTML = `<p>Latitude is ${latitude}° <br>Longitude is ${longitude}°</p>`

      var img = new Image()
      img.src = `https://maps.googleapis.com/maps/api/staticmap?center=${latitude},${longitude}&zoom=13&size=300x300&sensor=false`

      output.appendChild(img)
    };

    function error () {
      output.innerHTML = 'Unable to retrieve your location'
    };

    output.innerHTML = '<img src="./giphy.gif" alt="loading icon">'
  }
}())
