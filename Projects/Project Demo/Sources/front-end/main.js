
console.log('abc');

/**
 * Get list student
 */
function GetListStudent() {
  $.ajax({
    url: 'https://localhost:7190/api/student/list',
    type: 'GET',
    contentType: 'application/json',
    success: function(result) {
      console.log(result);
      var html = '';
      $.each(result, function(i, item) {
        html += '<tr>';
        html += '<td>' + item.fullName + '</td>';
        html += '<td>' + item.age + '</td>';
        html += '<td>' + item.address + '</td>';
        html += '<td>';
        html += '<a href="#editStudentModal" class="edit" data-toggle="modal" onclick="editStudent(' + item.id + ')">';
        html += '<i class="material-icons" data-toggle="tooltip" title="Edit">&#xE254;</i>';
        html += '</a>';
        html += '<a href="#deleteStudentModal" class="delete" data-toggle="modal" onclick="deleteStudent(' + item.id + ')">';
        html += '<i class="material-icons" data-toggle="tooltip" title="Delete">&#xE872;</i>';
        html += '</a>';
        html += '</td>';
        html += '</tr>';
      });
      $('#listStudent').html(html);
      $('.hint-text').html('Showing <b>' + result.length + '</b> students');
    },
    error: function(result, status) {
      console.log(status,result);
    },
  })
}

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
