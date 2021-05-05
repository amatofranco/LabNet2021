
$(document).ready(function () {

   $("#form").submit(function() {


      if ($("#inputName").val() == '') {
         $("#inputName").css('border', '1px solid red');

         alert("Por favor, ingrese su nombre");

         return false;
      }

      if ($("#inputLastname").val() == '') {
         $("#inputLastname").css('border', '1px solid red');

         alert("Por favor, ingrese su Apellido");

         return false;
      }

      else {


         $(".container").html ('<div class="alert alert-success" role="alert"> Se enviaron los datos</div>');

      }

   }
   );

   $("#reset").click(function () {

      $('#form').trigger("reset");

   }
   );

}
);