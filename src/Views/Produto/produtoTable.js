import React from 'react'

export default props => {

    const rows = props.Produtos.map(produto => {
        return (
            <tr key={produto.id}>
                <td>{produto.id}</td>
                <td>{produto.nomeProduto}</td>
                <td>{produto.quantidade}</td>
                <td>{produto.precoUnitario}</td>
                <td>
                    <button type="button" className="btn btn-primary" onClick={e => props.editar(produto.id)}>Editar</button>
                    <button type="button" className="btn btn-danger" onClick={e => props.deletar(produto.id)}>Deletar</button>
                </td>
            </tr>
        )
    })

    return (
        <div className="row">
            <div className="col-md-12">
                <div className="bs-component">
                    <table className="table table-hover">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Produto</th>
                                <th>Quantidade</th>
                                <th>Preço Unitario</th>
                                <th>Ações</th>
                            </tr>
                        </thead>
                        <tbody>
                            {rows}
                        </tbody>
                    </table>
                </div>
            </div>
        </div>

    )
}