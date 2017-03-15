import {EncodeService} from 'services/encodeService'
import {Upload} from 'upload/upload'

export class Encode {
    static inject() { return [EncodeService, Upload] };
    ftp = "315";
    tss = "80";
    files = "";
    power = "";
    encodeResult = "";
    showNeedFileWarning = false;
    constructor(EncodeService,Upload) {
        this.EncodeService = EncodeService;
        this.Upload = Upload;
    }

    Submit()
    {
        //need some validation before this..?
        this.EncodeService.Encode(this.tss,this.ftp).then(result => {
            this.encodeResult = result.encodeResult;
            if (this.encodeResult)
            {
                var pom = document.createElement('a');
                pom.setAttribute('href', 'Uploads/modifiedFile.fit');
                pom.setAttribute('download', 'ModifiedFile.fit');
                console.log(pom.getAttribute('href'));
                pom.style.display = 'none';
                document.body.appendChild(pom);
                pom.click();
                // document.body.removeChild(pom);
            }
        });
        
    }
}
