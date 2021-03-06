import {UploadService} from 'services/uploadService'
import {observable} from "aurelia-framework";

export class Upload {
  static inject() { return [UploadService] };
  @observable
  files = null;
  UploadService;
  uploaded;

  constructor(UploadService) {
    this.UploadService = UploadService;
  }

  Upload()
  {
    this.UploadService.UploadFile(this.files).then(result => {
          if (result.result)
          {
            this.uploaded = true;
          }
      });
  }

  filesChanged(newValue, oldValue)
  {
    this.uploaded = false;
  }
}
