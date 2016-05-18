#NODEJS examples

### Prerequisites
The following software must be installed:
1. NodeJS https://nodejs.org/en/download/
2. A software capable of interacting with Github (e.g. https://desktop.github.com/)

From Github desktop, clone scbd/api-examples to your local computer.

Open a NodeJS command prompt and go to the cloned folder:
```
cd C:\Users\xxx\Documents\GitHub\api-examples\NodeJS\ 
```
### Use the following command to install 
``` 
npm install
```
### Use the following commands to validate/upload/publish a national target
First validate the document you wish to upload
```
node validate-national-target.js
```
Upload the document as a draft
```
node createupdate-national-target.js
```
Finally, publish the document (make sure you have the rights to do so)
```
node workflow-request-national-target.js
```

