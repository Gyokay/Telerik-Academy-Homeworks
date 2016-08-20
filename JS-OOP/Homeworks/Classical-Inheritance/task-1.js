(function () {
    "use strict";

    var Person = (function () {

        var validateStringLen = function (str, minLen, maxLen, parameterName) {
            var isValid = str.length >= minLen && str.length <= maxLen;

            if (!isValid) {
                throw new Error("Invalid " + parameterName + " lenght");
            }
        };

        var validateNumerRange = function (num, min, max, parameterName) {
            var isValid = num >= min && num <= max;

            if (!isValid) {
                throw new Error("Invalid " + parameterName + " range");
            }
        };

        var tryParseStringToNumber = function (num) {
            var val = +num;

            if (isNaN(val)) {
                throw new Error("Number cannot be parsed");
            }

            return val;
        };

        function Person(fullname, age) {

            // this.setFirstname = firstname;
            // this.setLastname = lastname;
            this.setFullname = fullname;
            this.setAge = age;
        }

        Object.defineProperty(Person.prototype, "setFirstname", {
            set: function (value) {
                validateStringLen(value, 3, 20, "firstname");
                this.firstname = value;
            }
        });

        Object.defineProperty(Person.prototype, "setLastname", {
            set: function (value) {
                validateStringLen(value, 3, 20, "lastname");
                this.lastname = value;
            }
        });

        Object.defineProperty(Person.prototype, "setAge", {
            set: function (value) {
                const minValidAge = 0,
                    maxValidAge = 150;

                var age = tryParseStringToNumber(value);

                validateNumerRange(age, minValidAge, maxValidAge, "age");
                this.age = value;
            }
        });

        Object.defineProperty(Person.prototype, "setFullname", {
            set: function (value) {
                var splited = value.split(" ");

                this.setFirstname = splited[0];
                this.setLastname = splited[1];
            }
        });

        Object.defineProperty(Person.prototype, "getFullname", {
            get: function () { return this.firstname + " " + this.lastname; }
        });

        Person.prototype.introduce = function () {
            var message = "Hello! My name is " + this.getFullname + " and I am " + this.age + " years old.";

            return message;
        };

        return Person;

    } ());

    var me = new Person("John Doe", "42");
    console.log(me);

    var fullname = me.getFullname;
    console.log(fullname);

    console.log(me.introduce());


} ());
