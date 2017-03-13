import { HttpClient } from 'aurelia-fetch-client';
 
export class UploadService {
    static inject() { return [HttpClient] };
 
    constructor(http) {
        this.http = http;
 
        this.http.configure(config => {
            config
                .useStandardConfiguration()
                .withBaseUrl('/api/Upload');
        });
    }
 
    UploadFile(files) {
       var form = new FormData();
        for (let i = 0; i < files.length; i++) {
            form.append(`files[${i}]`, files[i]);
        }

        return this.http.fetch('', {
           method: "post",
           body: form,
           headers: new Headers() })
            .then(response => response.json())
            .catch(error => console.log(error));
    }
}