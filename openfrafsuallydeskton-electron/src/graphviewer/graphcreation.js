let dragAndDrop;

$.ready(function(){
    
    dragAndDrop = document.getElementById("dragarea");

    dragAndDrop.addEventListener("dragover", dragOver, false);
    dragAndDrop.addEventListener("drop", drop, false);

});

function createChart(){

}

function dragOver(e){
    e.stopPropagation();
    e.preventDefault();
}

function drop(e){
    e.stopPropagation();
    e.preventDefault();

    const dt = e.dataTransfer;
    const files = dt.files;

    let file;

    if(files.length === 0){
        file = files.item(0);


    }
}

