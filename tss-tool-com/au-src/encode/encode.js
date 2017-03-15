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

    file = "";
    constructor(EncodeService,Upload) {
        this.EncodeService = EncodeService;
        this.Upload = Upload;
    }

    Submit()
    {
        //need some validation before this..?
        this.files = Upload.getFiles();
        this.EncodeService.Encode(this.tss,this.ftp).then(result => {
            this.file = result.file;
            var pom = document.createElement('a');
            pom.setAttribute('href', '~/modifiedFile.fit');
            pom.setAttribute('download', 'modifiedFile.fit');
            console.log(pom.getAttribute('href'));
            pom.style.display = 'none';
            document.body.appendChild(pom);
            pom.click();
            // document.body.removeChild(pom);
        });
        
    }
}
