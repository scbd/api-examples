var request             = require('request');
var _                   = require('underscore');


var URL = {
    TOKEN           : 'https://api.cbddev.xyz/api/v2013/authentication/token',
    DOCUMENT        : 'https://api.cbddev.xyz/api/v2013/documents',
    DOCUMENTDRAFT   : 'https://api.cbddev.xyz/api/v2013/documents/x/versions/draft?schema=absPermit',
    WORKFLOW        : 'https://api.cbddev.xyz/api/v2013/workflows',
    VALIDATE        : 'https://api.cbddev.xyz/api/v2013/documents/x/validate?schema=absPermit'
}


var credentials  = require('../json-data/credentials.json');
var document     = require('../json-data/abs-permit.json')

var headers = { 'Accept': 'application/json', 'Content-Type': 'application/json;Charset=utf-8'};


request({ method: 'POST', url: URL.TOKEN ,headers:headers, body: JSON.stringify(credentials) }, function (error, response, data) {

    console.log(response.statusCode)

    if (response.statusCode!=201 && response.statusCode!=200)
        console.log("Error getting credentials" ,error);
    else {

         var url = URL.DOCUMENTDRAFT.replace('/x/', '/' + document.header.identifier + '/');

         console.log(url)
         var token = JSON.parse(data);

         var documentHeaders = _.extend(headers, {'realm': 'ABS-DEV'});
             documentHeaders.Authorization = 'Ticket ' + token.authenticationToken;

         request({ method: 'PUT', uri: url, body: JSON.stringify(document), headers: documentHeaders },
         function (error, response) {
            if (response.statusCode!=201 && response.statusCode!=200)
                console.log("Error saving document" ,JSON.parse(response.body));
            else {
                var newDocument = JSON.parse(response.body);
                var workflowData = {
                                    type: 'publishNationalRecord',
                                    version: '0.4',
                                    data: {
                                            "realm"      		: newDocument.realm,
                                            "documentID" 		: newDocument.documentID,
                                            "identifier" 		: newDocument.identifier,
                                            "title"      		: newDocument.workingDocumentTitle,
                                            "abstract"   		: newDocument.workingDocumentSummary,
                                            "metadata"   		: newDocument.workingDocumentMetadata,
                                            "additionalInfo"	: ''
                                        }
                                    }
                 request({ method: 'POST', uri: URL.WORKFLOW, body: JSON.stringify(workflowData), headers: documentHeaders },
                 function (error, response) {

                        console.log('workflow created', JSON.parse(response.body));
                 });
            }
        });
    }
});
