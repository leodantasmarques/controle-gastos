import { useEffect,useState } from "react";
import api from '../services/api';

function Despesas(){
    const [despesas, setDespesas] = useState([]);

    useEffect(() => {
        carregarDespesas();
    }, []);

    const carregarDespesas = async () => {
        try {
            const response = await api.get('/despessas');
            setDespesas(response.data);
        } catch (error) {
            console.error('Erro ao buscar despesas', error);
        }
    };

    return(
        <div>
            <h1>Lista de Despesas</h1>
            <ul>
                {despesas.map((despesa) => (
                    <li key={despesa.id}>
                        {despesa.nome} - R$ {despesa.valor}
                    </li>
                ))}
            </ul>
        </div>
    );
}

export default Despesas;