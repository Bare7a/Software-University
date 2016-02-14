function appendMessage(id, text) {
    var div = document.getElementById(id);

    var paragraph = document.createElement('p');
    paragraph.innerText = text;

    div.appendChild(paragraph);
}