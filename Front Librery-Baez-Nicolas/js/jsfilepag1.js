fetch("https://localhost:7118/api/Library/generos")
    .then(response => response.json())
    .then(generos => {
        console.log(generos);

        let body = document.getElementById("selectGenero")

        generos.forEach(genero => {
            body.innerHTML += `
                 <option value="${genero.id}">${genero.nombre}</option>
                `;

        });
    });

fetch("https://localhost:7118/api/Library/autores")
    .then(response => response.json())
    .then(autores => {
        console.log(autores);

        let body = document.getElementById("selectAutor")

        autores.forEach(autor => {
            body.innerHTML += `
                 <option value="${autor.id}">${autor.nombre}</option>
                `;

        });
    });


$(document).ready(function () {

    $('#btn-libro').click(function () {
        if ($('#form-ingresarlibro').valid() == false) {
            Swal.fire({
                title: "Error..",
                text: "Debe completar los campos..",
                icon: "error"
            });
        }

    });

    $('#form-ingresarlibro').validate({
        rules: {
            InputISBN: {
                required: true,
                digits: true
            },
            InputTitulo: {
                required: true
            },
            selectGenero: {
                required: true
            },
            selectAutor: {
                required: true
            },
            InputFecha: {
                required: true
            }
        },
        messages: {
            InputISBN: {
                required: "Error, este campo es requerido..",
                digits: "Error, debe ingresar solo digitos.."
            },
            InputTitulo: {
                required: "Error, este campo es requerido..",
            },
            selectGenero: {
                required: "Error, debe seleccionar un genero.."
            },
            selectAutor: {
                required: "Error, debe seleccionar un autor.."
            },
            InputFecha: {
                required: "Error, este campo es requerido.."
            }
        },
        submitHandler: function () {

            const idElement = document.getElementById("InputISBN")
            const nameElement = document.getElementById("InputTitulo")
            const fechaElement = document.getElementById("InputFecha")
            const autorElement = document.getElementById("selectAutor")
            const generoElement = document.getElementById("selectGenero")

            fetch("https://localhost:7118/api/Library", {
                method: 'POST',
                headers: {
                    "Content-Type": "application/json"
                },
                body: JSON.stringify({
                    isbn: idElement.value,
                    titulo: nameElement.value,
                    fechaPublicacion: new Date(fechaElement.value).toISOString(),
                    lAutorId: autorElement.value,
                    lGeneroId: generoElement.value
                })

            })
                .then(response => response.json())
                .then(response => {
                    console.log(response);
                })

            Swal.fire({
                title: "Success..",
                text: "Se cargo con éxito..",
                icon: "success"
            });

        }

    });
});