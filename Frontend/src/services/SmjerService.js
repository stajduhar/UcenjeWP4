import { httpService } from "./HttpService"


async function get(){
    return await httpService.get('/Smjer')
    .then((odgovor)=>{
        //console.table(odgovor.data);
        return odgovor.data;
    })
    .catch((e)=>{console.error(e)})
}

export default{
    get
}