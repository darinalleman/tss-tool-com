import { HttpClient } from 'aurelia-fetch-client';
 
export class EstimateService {
    static inject() { return [HttpClient] };
 
    constructor(http) {
        this.http = http;
 
        this.http.configure(config => {
            config
                .useStandardConfiguration()
                .withBaseUrl('/api/Estimate/Estimate');
        });
    }
 
    Estimate(zones) {
       var form = new FormData();
        for (let i = 0; i < zones.length; i++) {
            form.append(`zone[${i}]`, zones[i]);
        }
        this.http.configure(config => {
            config
                .useStandardConfiguration()
                .withBaseUrl('/api/Estimate');
        });

        return this.http.fetch('', {
           method: "post",
           body: form,
           headers: new Headers() })
            .then(response => response.json())
            .catch(error => console.log(error));
    }
}