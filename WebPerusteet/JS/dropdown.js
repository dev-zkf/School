function dropDown() {
  var x = document.getElementById("navBar");
  var oldClassName = "nav";
  if (x.className === oldClassName) {
    x.className += " responsive";
  } else {
    x.className = oldClassName;
  }
}
