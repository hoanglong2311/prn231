$(document).ready(function () {
  // Activate tooltip
  $('[data-toggle="tooltip"]').tooltip();

  // Select/Deselect checkboxes
  var checkbox = $('table tbody input[type="checkbox"]');
  $("#selectAll").click(function () {
    if (this.checked) {
      checkbox.each(function () {
        this.checked = true;
      });
    } else {
      checkbox.each(function () {
        this.checked = false;
      });
    }
  });
  checkbox.click(function () {
    if (!this.checked) {
      $("#selectAll").prop("checked", false);
    }
  });
});

// create function to update student by call api with axios
function updateStudent() {
  axios
    .put("/api/students", {
      id: document.getElementById("id").value,
      name: document.getElementById("name").value,
      email: document.getElementById("email").value,
      address: document.getElementById("address").value,
      phone: document.getElementById("phone").value,
    })
    .then(function (response) {
      console.log(response);
      window.location.href = "/students";
    })
    .catch(function (error) {
      console.log(error);
    });
}
