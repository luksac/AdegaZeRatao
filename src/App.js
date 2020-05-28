import React, {Component} from 'react';
import Navbar from './components/Navbar';
import { ButtonToolbar, Button } from 'react-bootstrap';
import {Modal, Row, Col, Form} from 'react-bootstrap';
import {Link} from 'react-router-dom';





  


class App extends Component{

        constructor(props){
            super(props);
            this.state = {
                Detalhes : false,
                Cervejas : [],
                status : false,
                statusModal : false,
                foto : [],
         
            };
            this.listaDetalhes = this.listaDetalhes.bind(this);
            
            
            
        }
        
        listaDetalhes(e) {
                
                var id = e;   
                this.setState({idDe : id});        
               // console.log(e); 
            fetch('https://localhost:44389/DeatlhesCerveja/SelecionaPorId/'+ id).then((r) => r.json())
            .then((json) => {
                
                let state = this.state;
                state.Detalhes = json;
                let fotomodal = 0;
                this.setState({Detalhes:json})
                this.setState({status : true});     
                this.setState({statusModal : true});
                this.setState({onHide : true});
                //console.log(json);
                
                
            })
                           
        }
       

        componentDidMount(){
                   
            fetch('https://localhost:44389/Cerveja/ativos').then((r) => r.json())
            .then((json) => {
                let state = this.state;
                state.Cervejas = json;
                this.setState(state);
              //  console.log(json);

            })
       
                
        }
          
        render(){
            let statusModal =() =>this.setState({statusModal : false});
            return(
                
                <div>
                    
                    <div>
                        
                    <Navbar />    
         
                    </div>
                    <div className="ajust" >
                        <div className="row col-md-8">
                            {this.state.Cervejas.map((Cerveja) => {
                                return(
                                    <div className="col-lg-4">
                                    <a key= {Cerveja.idCerveja} className="col-5 col-md-4">
                                    <div className="style-tree">
                                        <img src={Cerveja.foto} className="img-foto"/> 
                                        <p className="text-cerv">Descrição : {Cerveja.descricao}</p> 
                                        <p className="text-cerv">Tipo : {Cerveja.tipo}</p> 
                                        <p className="text-cerv">Categoriga : {Cerveja.categoria}</p> 
                                        <p className="text-cerv">Detalhes : {Cerveja.idDetalhes}</p> 
                                        
                                        
                                
                                        <ButtonToolbar>
                                        <Button variant='primary' onClick={(e) => this.listaDetalhes(Cerveja.idDetalhes)}   className="button">Detalhes
                                        </Button>
                                        
                                        {/* { <ModalComponent show={this.state.statusModal}
                                                onHide={statusModal}
                                                Id={this.state.Detalhes.IdDetalhes}>
                                                
                                        </ModalComponent> } */}
                                        </ButtonToolbar> 
                                                  
                                        <Modal show = {this.state.statusModal} onHide={statusModal} 
                                            {...this.props}
                                            size="lg"
                                            aria-labelledby="contained-modal-title-vcenter"
                                            centered
                                            >
                                            <Modal.Header closeButton>
                                            <Modal.Title id="contained-modal-title-vcenter">
                                            Adega Zé Ratão <span class="fas fa-beer "></span> 
                                            </Modal.Title>
                                            </Modal.Header>
                                            <Modal.Body>
                                            <p>
                                                Descrição Básica
                                            </p>
                                                <a key= {this.state.Detalhes.idDetalhe}>

                                                    

                                                <div>
                                                    {this.state.Cervejas.filter(Cerveja => Cerveja.idDetalhes === this.state.Detalhes.idDetalhe).map((Cerveja => { return (
                                                    ( 
                                                        <a key = {this.state.Id}>
                                                            <img src={Cerveja.foto} className="img-foto-modal"></img>

                                                        </a>
                                                    ))}))}
                                                </div>
                                         
                                                    
                                                    
                                                       
                                                    <p className="text-cerv-modal">Preço : R$  {this.state.Detalhes.precoSugerido}</p>
                                                    <p className="text-cerv-modal">Ranking : {this.state.Detalhes.ranking}</p>
                                                    <p className="text-cerv-modal">Quantidade : {this.state.Detalhes.produtoQuantidade}</p>
                                                </a>    
                                            
                                            <p>
                                                Descrição da Cerveja.
                                                <a >
                                                     <p className="text-cerv-modal-descricao">{this.state.Detalhes.descricaoDetalhe}</p>

                                                </a>
                                            </p>
                                            </Modal.Body>
                                            <Modal.Footer>
                                            <Link to="/Avaliar"><Button  className="button">Avaliar</Button></Link>
                                            <Button onClick={statusModal} className="button">Fechar</Button>
                                            </Modal.Footer>
                               
                                        </Modal>
                                        </div>
                                                       
                                                            

                                        
                                    </a>
                                </div>
                                    
                                );
                                
                                
                            })}
                        </div>

                    </div>
                    {/* { <ModalComponent show={this.state.statusModal}
                                                onHide={statusModal}
                                                Id={this.state.Detalhes.IdDetalhes}>
                                                
                                        </ModalComponent> } */} 
                </div>            
                

                
            );
            
        };
    };

export default App;