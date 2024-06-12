fetch("https://localhost:7118/api/Library/libros")
    .then(response => response.json())
    .then(library => {
        console.log(library);

        let body = document.getElementsByTagName("tbody")[0]

        library.forEach(libros => {
            if (libros.lAutorId) {
                fetch(`https://localhost:7118/api/Library/autores/${libros.lAutorId}`)
                    .then(response => response.json())
                    .then(autor => {
                        if (autor) {
                            fetch(`https://localhost:7118/api/Library/generos/${libros.lGeneroId}`)
                                .then(response => response.json())
                                .then(genero => {
                                    if (genero) {
                                        body.innerHTML += `
                                        <tr>
                                            <th>${libros.isbn}</th>
                                            <th>${libros.titulo}</th>
                                            <th>${autor.nombre}</th>
                                            <th>${genero.nombre}</th>
                                        </tr>
                                        `;
                                    }
                                });
                        }
                    });
            }
        });
    });