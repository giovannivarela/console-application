public class EnergyCompany
{
    public EnergyCompany(string EndpointSerialNumber, MeterModelId ModelId, int MeterNumber, string MeterFirmwareVersion, SwitchStatus SwitchState)
    {
        this.EndpointSerialNumber = EndpointSerialNumber;
        this.MeterNumber = MeterNumber;
        this.MeterFirmwareVersion = MeterFirmwareVersion;
        this.MeterModelId = ModelId;
        this.SwitchState = SwitchState;
    }

    public string EndpointSerialNumber { get; set; }
    public MeterModelId MeterModelId { get; set; }
    public int MeterNumber { get; set; }
    public string MeterFirmwareVersion { get; set; }
    public SwitchStatus SwitchState { get; set; }
}