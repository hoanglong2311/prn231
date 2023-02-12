$(document).ready(function () {
  GetAllStudents();

  function GetAllStudents() {
    $("table tbody").html("");
    $.ajax({
      url: "https://localhost:7190/api/student/list",
      type: "GET",
      contentType: "application/json",
      success: function (result, status, xhr) {
        $.each(result, function (index, item) {
          $("table tbody").append(`
            <tr>
              <td>
                <span class="custom-checkbox">
                  <input
                    type="checkbox"
                    id="checkbox2"
                    name="options[]"
                    value="1" />
                    <label for="checkbox2"></label>
                  </span>
              </td>
              <td>${item.fullName}</td>
              <td>${item.age}</td>
              <td>${item.address}</td>
              <td>
                <a href="#editStudentModal" class="edit" id="editBtn" data-toggle="modal" onclick="GetStudentById(${item.id})"
                    ><i
                      class="material-icons"
                      data-toggle="tooltip"
                      title="Edit"
                      >&#xE254;</i></a>
                <a
                    href="#deleteStudentModal"
                    class="delete"
                    data-toggle="modal"
                    ><i
                      class="material-icons"
                      data-toggle="tooltip"
                      title="Delete"
                      >&#xE872;</i
                      onclick="DeleteStudent(${item.id})"></a>
              </td>
            </tr>
          `);
        });
      },
    });
  }

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
});

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
