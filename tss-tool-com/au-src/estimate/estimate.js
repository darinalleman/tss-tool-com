import {EstimateService} from 'services/estimateService'

export class Estimate {
    static inject() { return [EstimateService] };
    zone1 = "162";
    zone2 = "176";
    zone3 = "188";
    zone4 = "200";
    zone5 = "215";
    tss = "";
    constructor(EstimateService) {
        this.EstimateService = EstimateService;
    }

    Submit()
    {
        //need some validation before this..?
        var zones = [];
        zones.push(this.zone1);
        zones.push(this.zone2);
        zones.push(this.zone3);
        zones.push(this.zone4);
        zones.push(this.zone5);

        this.EstimateService.Estimate(zones).then(result => {
            this.tss = result.tss;
        });
    }
}
