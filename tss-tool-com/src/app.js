import {UploadService} from 'services/uploadService'

export class App {
  static inject() { return [UploadService] };
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
}
