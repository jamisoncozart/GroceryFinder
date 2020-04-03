$(document).ready(function() {
  getStores()
  .then((data) => {
    console.log(data);
  })
  
  
  $("#stores").html();
})

async function getStores() {
  try {
    let response = await fetch("http://localhost:5000/api/stores/");
    if(response.ok && response.status == 200) {
      let jsonifiedResponse = await response.json();
      return jsonifiedResponse;
    } else {
      throw Error("Error: API request failed. Please try again");
    }
  } catch(error) {
    return error.message;
  }
}