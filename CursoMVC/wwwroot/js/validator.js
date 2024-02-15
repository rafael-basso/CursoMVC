// $(document).ready(function () {
    $("#formComentario").validate({
        debug: false,
        rules: {
          nome: {
            required: true,
            minlength: 2,
          },
          test_email: {
            email: true,
            maxlength: 10,
            required: false,
          },
          comentario: {
            required: true,
          },
        },
        messages: {
            nome: {
                required: "Nome é obrigatório.",
                minlength: "Digite pelo menos 2 caracteres."
            },
            test_email: {
                maxlength: "Digitar não mais do que 10 caracteres.",
                // required: "Email é obrigatório.",
                email: "Digite email válido."
            },
            comentario: {
                required: "Comentario é obrigatório.",
            },
        },
        submitHandler: function (form) {
            debugger
            $.ajax({
              url: '/Home/TestarAction',
              type: 'POST',
              data: { /* Optional data to send to the server */ },
              success: function(response) {                  
                  console.log(response);
              },
              error: function(xhr, status, error) {                  
                  console.log(error);
              }
          });          
        },
    });
// });
