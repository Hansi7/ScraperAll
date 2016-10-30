"use strict";
phantom.outputEncoding="gb2312"
var port, server, service,
    system = require('system');


if (system.args.length !== 2) {
    console.log('Usage: simpleserver.js <portnumber>');
    phantom.exit(1);
} else {
    port = system.args[1];
    server = require('webserver').create();

    service = server.listen(port, function (request, response) {

        console.log('Request at ' + new Date());
        //console.log(JSON.stringify(request, null, 4));
        if(request.method='post')
        {
            console.log('post found!');
            console.log(request.post['URL']);
            var page = require('webpage').create();
            page.open(request.post['URL'], function (status) {
                if (status != "success") {
                    console.log('FAIL to load the address');
                    //phantom.exit();
                }
                window.setTimeout(function () {
                    //page.render("333.png");
                    //console.log(page.content);
                    response.statusCode = 200;
                    response.headers = {
                        'Cache': 'no-cache',
                        'Content-Type': 'text/html'
                    };
                    response.write(page.content);
                    response.close();
                    //phantom.exit();
                }, 500);
            });
        }
        else
        {
            request.write('no post');
            request.close();

        }
    });

    if (service) {
        console.log('Web server running on port ' + port);
    } else {
        console.log('Error: Could not create web server listening on port ' + port);
        phantom.exit();
    }
}