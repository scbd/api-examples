var request             = require('request');
var _                   = require('underscore');


var URL = {
    TOKEN           : 'https://api.cbd.int/api/v2013/authentication/token',
    DOCUMENT        : 'https://api.cbd.int/api/v2013/documents',
    DOCUMENTDRAFT   : 'https://api.cbd.int/api/v2013/documents/x/versions/draft?schema=nationalTarget',
    WORKFLOW        : 'https://api.cbd.int/api/v2013/workflows',
    VALIDATE        : 'https://api.cbd.int/api/v2013/documents/x/validate?schema=nationalTarget'
}

var credentials  = require('../json-data/credentials.json');
var document     = require('../json-data/national-target.json')

var headers = { 'Accept': 'application/json', 'Content-Type': 'application/json;Charset=utf-8'};


request({ method: 'POST', url: URL.TOKEN ,headers:headers, body: JSON.stringify(credentials) }, function (error, response, data) {

    if (response.statusCode!=201 && response.statusCode!=200)
        console.log("Error getting credentials" ,error);
    else {

         var token = JSON.parse(data);

         var documentHeaders = _.extend(headers, {'realm': 'CHM-DEV'});
             documentHeaders.Authorization = 'Ticket ' + token.authenticationToken;

         request({ method: 'PUT', uri: URL.VALIDATE, body: JSON.stringify(document), headers: documentHeaders },
         function (error, response) {
             var result = JSON.parse(response.body);
             if(result.errors)
                console.log("Document errors:", result.errors);
            else {
                console.log("Document is valid");
            }
        });
    }
});
