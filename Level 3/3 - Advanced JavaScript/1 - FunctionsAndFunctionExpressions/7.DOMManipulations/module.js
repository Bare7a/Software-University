var domModule = (function(){
    var getElement = function getElement(selector){
        if (!(selector instanceof Element)){
            selector = document.querySelector(selector);
        }

        return selector;
    };

    var validateInput = function (element){
        if (!(element instanceof Element)){
            element = getElement(element);
        }

        return element;
    };

    function appendChild(child, parent){
        parent = validateInput(parent);
        child  = validateInput(child);

        parent.appendChild(child);
    }

    function removeChild (parent, child){
        parent = validateInput(parent);
        child  = validateInput(child);

        parent.removeChild(child);
    }

    function retrieveElements (selector){
        return document.querySelectorAll(selector);
    }

    function addHandler (elements, eventType, eventHandler){
        if (!(elements instanceof Element)&&!Array.isArray(elements)){
            elements = retrieveElements(elements);
        }

        for (var index in elements) {
            if (elements[index] instanceof Element){
                elements[index].addEventListener(eventType, eventHandler);
            }
        }
    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        retrieveElements: retrieveElements,
        addHandler: addHandler
    }
})();

var liElement = document.createElement("li");
domModule.appendChild(liElement,".birds-list");
domModule.removeChild("ul.birds-list","li:first-child");
domModule.addHandler("li.bird", 'click', function(){ alert("I'm a bird!") });
var elements = domModule.retrieveElements(".bird");

console.log(elements);
