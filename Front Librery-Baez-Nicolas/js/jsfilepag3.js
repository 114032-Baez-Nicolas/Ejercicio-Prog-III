document.addEventListener('DOMContentLoaded', function () {
    fetch("https://localhost:7118/api/Library/libros")
        .then(response => response.json())
        .then(libros => {
            let selectLibro = document.getElementById('selectLibro');
            selectLibro.innerHTML = '<option selected disabled>Seleccione el libro..</option>';
            libros.forEach(libro => {
                let option = document.createElement('option');
                option.value = libro.isbn;
                option.text = libro.isbn;
                selectLibro.appendChild(option);
            });
        })
});

document.getElementById('selectLibro').addEventListener('change', function () {
    let isbnSeleccionado = this.value;
    fetch(`https://localhost:7118/api/Library/libros/${isbnSeleccionado}`)
        .then(response => response.json())
        .then(libro => {
            document.getElementById('inputTitulo').value = libro.titulo;

            fetch(`https://localhost:7118/api/Library/generos/${libro.lGeneroId}`)
                .then(response => response.json())
                .then(genero => {
                    document.getElementById('inputGenero').value = genero.nombre;
                });

            fetch(`https://localhost:7118/api/Library/autores/${libro.lAutorId}`)
                .then(response => response.json())
                .then(autor => {
                    document.getElementById('inputAutor').value = autor.nombre;
                });
        });
});


$(document).ready(function () {

    $('#btn-EliminarLibro').click(function () {
        if ($('#form-ingresarlibro').valid() == false) {
            Swal.fire({
                title: "Error..",
                text: "Debe completar los campos..",
                icon: "error"
            });
        }

    });

    $('#form-deleteLibros').validate({
        rules: {
            selectLibro: {
                required: true,
            }
        },
        messages: {
            selectLibro: {
                required: "Error, debe seleccionar un libro.."
            }
        },
        submitHandler: function () {

            let isbnSeleccionado = document.getElementById('selectLibro').value;
            fetch(`https://localhost:7118/api/Library/${isbnSeleccionado}`, {
                method: 'DELETE'
            })

            Swal.fire({
                title: "Success..",
                text: "Se elimino con éxito..",
                icon: "success"
            });

        }

    });
});