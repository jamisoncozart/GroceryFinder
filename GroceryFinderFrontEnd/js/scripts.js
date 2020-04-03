$(document).ready(function() {
  let storesDiv = $("#stores");
  let searchField = $("#searchParam");
  let nameInput = $("input#name");
  let cityInput = $("input#city");
  let descriptionInput = $("input#description");
  let editFormDiv = $("#edit");
  let storeToEdit = 0;
  let jsonData;
  
  getStores(null)
  .then((stores) => {
    jsonData = stores;
    storesDiv.html(createDomString(jsonData));
  });
  
  $("#searchButton").click(function(event) {
    event.preventDefault();
    let searchParam = searchField.val();
    searchField.empty();
    getStores(searchParam)
    .then(stores => {
      storesDiv.html(createDomString(stores));
    });
  });

  $("#stores").on("click", ".editButton", function() {
    let storeId = $(this).attr("id");
    storeToEdit = storeId;
    $("#stores").hide();
    editFormDiv.show();
  });

  $("#editForm").submit(function(event) {
    event.preventDefault();
    editFormDiv.hide();
    let jsonBody = createJsonBody(nameInput.val(), cityInput.val(), descriptionInput.val());
    console.log(jsonBody);
    editStore(jsonBody, storeToEdit)
    .then( () => {
      location.reload();
    });
  });
});

//make request to get all stores from API
async function getStores(searchParam) {
  try {
    if(searchParam == null) {
      let response = await fetch("http://localhost:5000/api/stores/");
      if(response.ok && response.status == 200) {
        let jsonifiedResponse = await response.json();
        return jsonifiedResponse;
      } else {
        throw Error("Error: API request failed. Please try again");
      }
    } else {
      let response = await fetch(`http://localhost:5000/api/stores/?name=${searchParam}`);
      if(response.ok && response.status == 200) {
        let jsonifiedResponse = await response.json();
        return jsonifiedResponse;
      } else {
        throw Error("Error: Search parameter API request failed. Please try again");
      }
    }
  } catch(error) {
    return error.message;
  }
}

//make put request to api to edit store details
async function editStore(jsonBody, storeId)
{
  try {
    let response = await fetch(`http://localhost:5000/api/stores/${storeId}`, {
      method: "PUT",
      headers: {
        "Accept": "application/json",
        "Content-Type": "application/json"
      },
      body: JSON.stringify(jsonBody)
    });
    if(response.ok && response.status == 200) {
      let jsonifiedResponse = await response.json();
      return jsonifiedResponse;
    } else {
      throw Error("Error: Put request to API failed. Please try again");
    }
  }
  catch(error) {
    return error.message;
  }
}

function createDomString(stores)
{
  let appendString = "";
  for(let i = 0; i < stores.length; i++) {
    appendString += `<div class="store card card-default"><div class="card-header"><h4>${stores[i].name}</h4><div class="btnDiv"><button class="editButton btn btn-warning btn-sm" id=${stores[i].storeId}><strong>Edit</strong></button><button class="deleteButton btn btn-danger btn-sm" id=${stores[i].storeId}><strong>X</strong></button></div></div><div class="card-body"><ul><li><strong>City:</strong> ${stores[i].city}</li><li><strong>Hours:</strong> ${stores[i].openHour} - ${stores[i].closeHour}</li><li><strong>Delivery:</strong> ${stores[i].delivery}</li></ul><p>${stores[i].description}</p></div></div>`;
  }
  return appendString;
}


function createJsonBody(name, city, description) {
  let jsonObj = {
    "name": name,
    "city": city,
    "description": description
  }
  return jsonObj;
}