var page = require('webpage').create();

    page.open('http://localhost:' + 80 + '/', 'post', 'URL=http://www.hao123.com/', function (status) {
    if (status !== 'success') {
        console.log('Unable to post!');
    } else {
        console.log(page.content);
    }
    phantom.exit();
});