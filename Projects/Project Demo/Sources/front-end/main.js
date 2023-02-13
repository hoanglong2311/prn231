
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
