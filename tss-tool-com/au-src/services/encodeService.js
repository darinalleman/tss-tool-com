import { HttpClient } from 'aurelia-fetch-client';
 
export class EncodeService {
    static inject() { return [HttpClient] };
 
    constructor(http) {
        this.http = http;
    }
 
    Encode(tss,ftp) {
       var form = new FormData();
       form.append("tss", tss);
       form.append("ftp", ftp);

        this.http.configure(config => {
            config
                .useStandardConfiguration()
                .withBaseUrl('/api/WritePower');
        });

        return this.http.fetch('', {
           method: "post",
           body: form,
           headers: new Headers() })
            .then(response => response.json())
            .catch(error => console.log(error));
    }
}