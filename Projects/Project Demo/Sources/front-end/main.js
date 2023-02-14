
console.log('abc');
function addStudent() {
  console.log('add student');
  $.ajax({
    url: 'https://localhost:7190/api/student/save',
    type: 'POST',
    contentType: 'application/json',
    data: JSON.stringify({
      fullName: $("#addName").val(),
      age: $("#addAge").val(),
      address: $("#addAddress").val()
    }),
    success: function(result,status, xhr) {
      if(result == 1){
        $('#addStudentModal').modal().hide();
        window.location.reload();
        console.log('close modal');
      }
    },
    error: function(result,status, xhr) {
      console.log(status,result);
    },
  })
}


function deleteStudentById() {
  console.log("------- DELETE ----->");
  $.ajax({
    url: DELETE_STUDENT_API_PATH,
    type: "DELETE",
    contentType: "application/json",
    data: JSON.stringify({
      id: $("#studentId").val(),
    }),
    success: function (result, status, xhr) {
      if (result == 1) {
        GetAllStudents();
        $("#deleteStudentModal").modal("hide");
        // window.location.reload();
        console.log('----- DELETED ------');
      }
    },
    error: function (result, status, xhr) {
      console.log('----- Something Wrong! ------');
      console.log(status, result);
    },
  });
}

