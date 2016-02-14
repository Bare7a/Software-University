function testContext(){
    console.log(this);
}

function test(){}

var obj = {
    print: 'this is object'
};
//testContext(); //global
//testContext.call(test); //function
//testContext.call(obj); //object
//new testContext(); //print texContext as object