const url = 'http://localhost:56155/api/Laptop';
document.getElementById('Button1').addEventListener('click',getData);

function getData(){
    var requestOptions = {
        method: 'GET',
        redirect: 'follow'
    };

    fetch(url, requestOptions)
    .then(response => response.text())
    .then(result => showData(result));
}
function showData(data){
    document.getElementById('contentDiv').innerHTML = data;
}

//for getting single record
document.getElementById('Button2').addEventListener('click',getSingle);

 function getSingle(){

     var id=document.getElementById("inputBox").value;

     var url='http://localhost:56155/api/Laptop/'+id;

    fetch(url)

    .then(response => response.text())

    .then(result => showRecord(result))

    .catch(error => console.log('Error! The laptop you are looking for does not exist in the database', error));}

function showRecord(data) {

document.getElementById('contentDiv').innerHTML = data;

}

//post function

function sendJSON(){
    let laptopName = document.getElementById("laptopNameBox");
    let laptopBrand = document.getElementById("laptopBrandBox");
    let laptopSize = document.getElementById("laptopSizeBox");
    let laptopStorage = document.getElementById("laptopStorageBox");
    let laptopPrice = document.getElementById("laptopPriceBox");

    // Creating a XHR object
    let xhr = new XMLHttpRequest();
    let url = 'http://localhost:56155/api/Laptop';

    // open a connection
    xhr.open("POST", url, true);

    // Set the request header i.e. which type of content you are sending
    xhr.setRequestHeader("Content-Type", "application/json");

    // Create a state change callback
    xhr.onreadystatechange = function () {
    if (xhr.readyState === 4 && xhr.status === 200) {
    // Print received data from server
    result.innerHTML = this.responseText;    
    }
    
    };

    // Converting JSON data to string    
    var data = JSON.stringify({ "laptopName": laptopName.value , "laptopBrand":laptopBrand.value, "laptopSize":laptopSize.value, "laptopStorage": laptopStorage.value, "laptopPrice": laptopPrice.value });
    // Sending data with the request
    xhr.send(data);    
    }



    //Search function
    function search() {
        var id=document.getElementById("search").value;
        var url="http://localhost:56155/api/Laptop/Laptop/"+id;
        fetch(url)
        .then((res) => res.text())
        .then(ans => showData(ans))  
        }
      function showData(data)
      {
    
          document.getElementById('contentDiv').innerHTML=data;
    
      }