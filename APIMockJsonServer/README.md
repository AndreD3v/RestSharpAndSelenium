# Api Mock (running json-server)

Demo project using json-server (for more info see :: https://github.com/typicode/json-server).

## Description

Do you want a different API to test than the common used Petstore, for experimenting with your test tools? Here you have one :-) You can run it locally! 
And above all you can adjust it easilly. Add you own endpoints and own data easily.

## Installation

- Clone this GIT folder to your local machine;
- install json-server with the following cmd comands :: npm install -g json-server
- Run powershell script 'LaunchAPImock.ps1' (non-primair mouseclick > Run with Powershell)

Note :: the API service can be killed with [CTRL] + [C].

## Run (local)

1. Run powershell script 'LaunchAPImock.ps1' (non-primair mouseclick > Run with Powershell)
1. The Powershell script does return thi initial endpoints wich are curently available.
1. e.g. http://localhost:3000/functiontitles if you use this in its own you will get back all data available, but of course you cna use the query parameters to make a sub selection

A few simple examples :: 

- http://localhost:3000/functiontitles?name=Daniel (search based on name label)
- http://localhost:3000/knowledge/2 (search based on id label)
- http://localhost:3000/experience?id=1&id=2 (search based on combining id labels)

## Add your own endpoints and data

1. Kill the runing server with [CTRL] + [C].
1. Open the db.json file
1. If you have played with the above examples you probably will recognize the structure of this file fast. 
1. just add a new endpoint by adding a new key-value pair at the same level as all other endpoints. Note the value can have all valid json values. So all current examples are arrays, but objects/strings are of course also valid. 
1. Save the adjusted file and run again the powershell script.