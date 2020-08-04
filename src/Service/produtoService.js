import ApiService from './apiService'

class ProdutoService extends ApiService{

    constructor(){
        super('/api/produto');
    }

    cadastrar(objeto){
        return this.post('',objeto);
    }

    obterProdutos(){
        return this.get('/');
    }

    obterOrdenado(){
        return this.get('');
    }

    deletar(id){
        return this.delete(`/${id}`)
    }

    obterPorId(id){
        return this.get(`/${id}`)
    }

    editar(objeto){
        return this.put('',objeto);
    }

    obterNome(){
        return this.get('/obterProdutos');
    }
}


export default ProdutoService;