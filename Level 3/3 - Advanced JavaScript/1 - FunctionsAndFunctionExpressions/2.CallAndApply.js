function printArgsInfo (){
    var type;

    for (var i = 0; i < arguments.length; i++) {
        type = typeof arguments[i];
        if (Array.isArray(arguments[i])){
            type = 'array';
        }

        console.log(arguments[i] + ' (' + type + ' )')

    }
    console.log();
}

printArgsInfo.call(null, 2, 5, 'Pesho', []);
printArgsInfo.apply(null, [2, 5, 'Pesho', []]);