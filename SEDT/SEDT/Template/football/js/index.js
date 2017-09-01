$(document).ready(function(){
  $(".player__item").draggable({
   containment:".field",
   cursor: "grabbing"
  })
});

$(".player__item").on('mouseover', function(){
    //alert(11);
    // not sure if:
          $(this).find(".player__item--card").css("display", "flex");
  
       //so:  
     
    //$(this.children[2]).css("display", "flex");
});

$(".player__item").on('mouseout', function(){
    //alert(11);
    // not sure if:
          $(this).find(".player__item--card").css("display", "none");
  
       //so:  
     
    //$(this.children[2]).css("display", "flex");
});

/*function cardShow(){
  document.getElementsByClassName("player__item--card").style.display = "flex";
};

document.getElementsByClassName("player__item").addEventListener("click", cardShow());*/