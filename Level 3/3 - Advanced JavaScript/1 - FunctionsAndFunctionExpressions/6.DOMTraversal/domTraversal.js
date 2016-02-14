var selector = '.birds', tab = '\t';

function traverse(selector) {
    var startNode = document.querySelector(selector);
    recursiveTraverse(startNode, '');

    function recursiveTraverse(node, indent) {
        var line = indent + node.nodeName.toLowerCase() + ': ';

        for (var i = 0; i < node.attributes.length; i++) {
            line += node.attributes[i].name + '"' + node.attributes[i].value + '"';
        }

        console.log(line);

        for (i = 0; i < node.childNodes.length; i++) {
            var child = node.childNodes[i];
            if (child.nodeType === 1) {
                recursiveTraverse(child, indent + tab)
            }
        }
    }
}

traverse(selector);
