
let request             = require('superagent');
let _                   = require('underscore');


let URL = {
    DOCUMENT        : 'https://api.cbd.int/api/v2013/documents',
    INDEX           : 'https://api.cbd.int/api/v2013/index/select'
}


async function loadRecords(){
    

    let headers = { 'Accept': 'application/json', 'Content-Type': 'application/json;Charset=utf-8'};

    let indexQuery = {
        q : "realm_ss:abs AND schema_s:absPermit AND government_s:za", // za for south africa, can add more filters like regions_ss, usages_ss dateOfExpiry_dt etc, 
        fl: 'identifier_s, government_s', //can add more fields if required, if the fl field is skipped, all fields will be returned
        rows:10000, //the result set contains number of records found if pagination is required.
        start:0
    }
    const response  = await request .get(URL.INDEX)
                                    .set(headers)
                                    .query(indexQuery);

    
    // console.log(response.statusCode)

    if (response.statusCode!=201 && response.statusCode!=200)
        console.log("Error getting document from index" ,error);
    else {

        const indexDocuments = response.body.response.docs;
        const documents      = []
        for (let index = 0; index < indexDocuments.length; index++) {
            const element = indexDocuments[index];
            const documentResponse = await request.get(`${URL.DOCUMENT}/${encodeURIComponent(element.identifier_s)}/info`);
            if (documentResponse.statusCode!=201 && documentResponse.statusCode!=200)
                console.log("Error getting document details" ,element.identifier_s, error);
            else {
                documents.push(documentResponse.body)

                console.log(documentResponse.body);
            }
        }

        console.log(`Documents loaded, ${documents.length}`);

    }

}
// )();

loadRecords();