import {EstimateService} from 'services/estimateService'

export class Estimate {
    static inject() { return [EstimateService] };
    zone1 = "";
    zone2 = "";
    zone3 = "";
    zone4 = "";
    zone5 = "";
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

        });
    }
}
