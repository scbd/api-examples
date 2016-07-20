var request             = require('request');
var _                   = require('underscore');


var URL = {
    TOKEN       : 'https://chm.cbd.int/api/v2013/authentication/token',
    DOCUMENT    : 'https://api.cbd.int/api/v2013/documents',
    WORKFLOW    : 'https://api.cbd.int/api/v2013/workflows',
}

var credentials  = require('../json-data/credentials.json');
var document     = require('../json-data/national-target.json')

var headers = { 'Accept': 'application/json', 'Content-Type': 'application/json;Charset=utf-8'};


request({ method: 'POST', url: 'https://absch.cbd.int/api/v2013/authentication/token',headers:headers, body: JSON.stringify(credentials) }, function (error, response, data) {

    if (response.statusCode!=201 && response.statusCode!=200)
        console.log("Error getting credentials" ,error);
    else {

         var url = URL.DOCUMENT +'/'+ document.header.identifier + '/versions/draft?schema=nationalTarget';
         var token = JSON.parse(data);

         var documentHeaders = _.extend(headers, {'realm': 'CHM-DEV'});
             documentHeaders.Authorization = 'Ticket ' + token.authenticationToken;

         request({ method: 'PUT', uri: url, body: JSON.stringify(document), headers: documentHeaders },
         function (error, response, data) {

                console.log("Results:,", JSON.parse(response.body));
        });
    }
});
