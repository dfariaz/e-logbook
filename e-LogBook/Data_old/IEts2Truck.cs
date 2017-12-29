// Decompiled with JetBrains decompiler
// Type: VTMLive.Data.IEts2Truck
// Assembly: VTMLive, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 405901AF-83ED-4E80-B7BB-F0DDF2F4489D
// Assembly location: C:\Users\Deivid Farias\AppData\Local\Apps\2.0\M3LJPQZ8.L6C\9AVGE6T1.ZRW\vtml..tion_0000000000000000_0001.0001_e9801713934c92a6\VTMLive.exe

namespace VTMLive.Data
{
  public interface IEts2Truck
  {
    float Speed { get; }

    IEts2Vector Acceleration { get; }

    IEts2Placement Placement { get; }

    float Odometer { get; }

    float CruiseControlSpeed { get; }

    string Id { get; }

    string Make { get; }

    string Model { get; }

    int Gear { get; }

    int DisplayedGear { get; }

    int ForwardGears { get; }

    int ReverseGears { get; }

    float EngineRpm { get; }

    float EngineRpmMax { get; }

    float Fuel { get; }

    float FuelCapacity { get; }

    float FuelAverageConsumption { get; }

    float UserSteer { get; }

    float UserThrottle { get; }

    float UserBrake { get; }

    float UserClutch { get; }

    float GameSteer { get; }

    float GameThrottle { get; }

    float GameBrake { get; }

    float GameClutch { get; }

    int RetarderBrake { get; }

    int RetarderStepCount { get; }

    int ShifterSlot { get; }

    float AirPressure { get; }

    float BrakeTemperature { get; }

    float Adblue { get; }

    float AdblueAverageConsumption { get; }

    float OilPressure { get; }

    float OilTemperature { get; }

    float WaterTemperature { get; }

    float BatteryVoltage { get; }

    float AdblueCapacity { get; }

    float WearEngine { get; }

    float WearTransmission { get; }

    float WearCabin { get; }

    float WearChassis { get; }

    float WearWheels { get; }

    IEts2Vector Head { get; }

    IEts2Vector Cabin { get; }

    IEts2Vector Hook { get; }

    string ShifterType { get; }

    bool CruiseControlOn { get; }

    bool WipersOn { get; }

    bool ParkBrakeOn { get; }

    bool MotorBrakeOn { get; }

    bool EngineOn { get; }

    bool ElectricOn { get; }

    bool BlinkerLeftActive { get; }

    bool BlinkerRightActive { get; }

    bool BlinkerLeftOn { get; }

    bool BlinkerRightOn { get; }

    bool LightsParkingOn { get; }

    bool LightsBeamLowOn { get; }

    bool LightsBeamHighOn { get; }

    bool LightsAuxFrontOn { get; }

    bool LightsAuxRoofOn { get; }

    bool LightsBeaconOn { get; }

    bool LightsBrakeOn { get; }

    bool LightsReverseOn { get; }

    bool BatteryVoltageWarningOn { get; }

    bool AirPressureWarningOn { get; }

    bool AirPressureEmergencyOn { get; }

    bool AdblueWarningOn { get; }

    bool OilPressureWarningOn { get; }

    bool WaterTemperatureWarningOn { get; }

    float LightsDashboardValue { get; }

    bool LightsDashboardOn { get; }

    bool FuelWarningOn { get; }

    float FuelWarningFactor { get; }

    float AirPressureWarningValue { get; }

    float AirPressureEmergencyValue { get; }

    float OilPressureWarningValue { get; }

    float WaterTemperatureWarningValue { get; }

    float BatteryVoltageWarningValue { get; }
  }
}
