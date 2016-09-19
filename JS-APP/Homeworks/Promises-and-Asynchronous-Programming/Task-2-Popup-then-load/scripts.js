;(function () {
  'use strict'

  window.onload = load

  function load () {
    redirect()
    counter('counter')
  }

  function redirect () {
    let promise = new Promise((resolve, reject) => {
      window.setTimeout(() => {
        resolve('https://telerikacademy.com/')
      }, 5000)
    })

    promise.then(val => {
      window.location = val
    })
    .catch(reason => window.alert(reason))
  }

  function counter (el) {
    let counterElement = document.getElementById(el)
    let currentSecond = +(counterElement.innerText)

    if (currentSecond > 0) {
      window.setTimeout(() => {
        counterElement.innerText = --currentSecond

        // recursive call
        counter(el)
      }, 1000)
    } else {
      return
    }
  }
}())
