function eliminar($id) {


    swal({
        title: "Mensaje",
        text: "¿Desea eliminar la categoría seleccionada?",
        type: "warning",
        showCancelButton: true,

        confirmButtonText: "Sí",
        confirmButtonColor: "#DD6B55",

        cancelButtonText: "No",

        closeOnConfirm: true
    },



        function () {

            jQuery.ajax({

                url: "/Tareas/Borrar/" + "?Id=" + $Id,
                type: "GET",
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (data) {

                    if (data.resultado) {
                        //datatable.ajax.reload();


                    } else {
                        swal("Mensaje", "No se pudo eliminar ", "warning")
                    }
                },
                error: function (error) {
                    console.log(error)
                },
                beforeSend: function () {

                },
            });
        });

}