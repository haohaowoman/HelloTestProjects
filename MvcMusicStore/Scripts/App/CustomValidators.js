/// <reference path="jquery.validate.js"/>
/// <reference path="jquery.validate.unobtrusive.js"/>

$.validator.unobtrusive.adapters.addSingleVal("maxlength", "wordcount");

$.validator.addMethod("maxlength", function (value, element, maxlength) {
    if (value) {
        if (value.split(' ').length > maxlength) {
            return false;
        }
    }
})
