$(document).ready(function() {
  getStores()
  .then((stores) => {
    console.log(stores);
    let appendString = "";
    for(let i = 0; i < stores.length; i++) {
      appendString += `<div class="store"><h3>${stores[i].name}</h3><ul><li>City: ${stores[i].city}</li><li>Hours: ${stores[i].openHour} - ${stores[i].closeHour}</li><li>Delivery: ${stores[i].delivery}</li></ul><p>${stores[i].description}</p></div>`;
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