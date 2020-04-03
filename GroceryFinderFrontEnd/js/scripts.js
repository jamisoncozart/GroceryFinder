$(document).ready(function() {
  getStores()
  .then((stores) => {
    console.log(stores);
    let appendString = "";
    for(let i = 0; i < stores.length; i++) {
      appendString += `<div class="store card card-default"><div class="card-header"><h4>${stores[i].name}</h4></div><div class="card-body"><ul><li><strong>City:</strong> ${stores[i].city}</li><li><strong>Hours:</strong> ${stores[i].openHour} - ${stores[i].closeHour}</li><li><strong>Delivery:</strong> ${stores[i].delivery}</li></ul><p>${stores[i].description}</p></div></div>`;
    }
    $("#stores").html(appendString);
  })
  
  
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