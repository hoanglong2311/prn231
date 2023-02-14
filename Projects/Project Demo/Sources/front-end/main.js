console.log("abc");

/**
 * Get list student
 */
function GetListStudent() {
  $.ajax({
    url: "https://localhost:7190/api/student/list",
    type: "GET",
    contentType: "application/json",
    success: function (result) {
      console.log(result);
      var html = "";
      $.each(result, function (i, item) {
        html += "<tr>";
        html += "<td>" + item.fullName + "</td>";
        html += "<td>" + item.age + "</td>";
        html += "<td>" + item.address + "</td>";
        html += "<td>";
        html +=
          '<a href="#editStudentModal" class="edit" data-toggle="modal" onclick="GetStudentById(' +
          item.id +
          ')">';
        html +=
          '<i class="material-icons" data-toggle="tooltip" title="Edit">&#xE254;</i>';
        html += "</a>";
        html +=
          '<a href="#deleteStudentModal" class="delete" data-toggle="modal" onclick="deleteStudent(' +
          item.id +
          ')">';
        html +=
          '<i class="material-icons" data-toggle="tooltip" title="Delete">&#xE872;</i>';
        html += "</a>";
        html += "</td>";
        html += "</tr>";
      });
      $('#listStudent').html(html);
      $('.hint-text').html('Showing <b>' + result.length + '</b> students');
    },
    error: function (result, status) {
      console.log(status, result);
    },
  });

  window.GetStudentById = function (id) {
    console.log("get student by id");
    $.ajax({
      url: "https://localhost:7190/api/student/id?id=" + id,
      type: "GET",
      contentType: "application/json",
      success: function (result, status, xhr) {
        $("#studentName").val(result.fullName);
        $("#studentAge").val(result.age);
        $("#studentAddress").val(result.address);
        $("#studentId").val(result.id);
      },
    });
  };

  window.UpdateStudent = function () {
    console.log("update student");
    $.ajax({
      url: "https://localhost:7190/api/student/update",
      type: "PUT",
      contentType: "application/json",
      data: JSON.stringify({
        id: $("#studentId").val(),
        fullName: $("#studentName").val(),
        age: $("#studentAge").val(),
        address: $("#studentAddress").val(),
      }),
      success: function (result, status, xhr) {
        if (result == 1) {
          GetAllStudents();
          $("#editStudentModal").modal("hide");
          // window.location.reload();
        }
      },
    });
  };
}

function addStudent() {
  console.log("add student");
  $.ajax({
    url: "https://localhost:7190/api/student/save",
    type: "POST",
    contentType: "application/json",
    data: JSON.stringify({
      fullName: $("#addName").val(),
      age: $("#addAge").val(),
      address: $("#addAddress").val(),
    }),
    success: function (result, status, xhr) {
      if (result == 1) {
        $("#addStudentModal").modal().hide();
        window.location.reload();
        console.log("close modal");
      }
    },
    error: function (result, status, xhr) {
      console.log(status, result);
    },
  });
}
