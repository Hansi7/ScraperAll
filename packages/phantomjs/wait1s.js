var page = require('webpage').create(),
system=require('system');
//var url = 'http://www.iqiyi.com/v_19rr98odxg.html';
var url = system.args[1];
page.open(url, function (status)
{
    if (status != "success")
    {
        console.log('FAIL to load the address');
        phantom.exit();
    }
    page.evaluate(function()
    {
    });

    window.setTimeout(function ()
    {
        //page.render("Web.png");
        console.log(page.content);
        phantom.exit();
    }, 1000);

});