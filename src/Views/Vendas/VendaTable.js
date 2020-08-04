import React from 'react'

export default props => {

  /*  const rows = props.produtos.map(produto => {
        return (
            <tr key={produto.idProduto}>
                <td>{produto.idProduto}</td>
                <td>{produto.nomeProduto}</td>
                <td>{produto.quantidade}</td>
                <td>{produto.precoUnitario}</td>
                <td>
                    <button type="button" className="btn btn-primary" onClick={e => props.editar(produto.idProduto)}>Editar</button>
                    <button type="button" className="btn btn-danger" onClick={e => props.deletar(produto.idProduto)}>Deletar</button>
                </td>
            </tr>
        )
    })
*/
    return (
        <div className="row">
            <div className="col-md-12">
                <div className="bs-component">
                    <table className="table table-hover">
                        <thead>
                            <tr>
                                <th>ID</th>
                                <th>Data do Pedido</th>
                                <th>Quantidade</th>
                                <th>ID do produto</th>
                                <th>ID do vendedor</th>
                                <th>Nome do Produto</th>
                                <th>Nome do Vendedor</th>
                                <th>Ações</th>
                            </tr>
                        </thead>
                        <tbody>
                            
                        </tbody>
                    </table>
                </div>
            </div>
        </div>

    )
}