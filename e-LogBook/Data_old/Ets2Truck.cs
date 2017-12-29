// Decompiled with JetBrains decompiler
// Type: VTMLive.Data.Ets2Truck
// Assembly: VTMLive, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 405901AF-83ED-4E80-B7BB-F0DDF2F4489D
// Assembly location: C:\Users\Deivid Farias\AppData\Local\Apps\2.0\M3LJPQZ8.L6C\9AVGE6T1.ZRW\vtml..tion_0000000000000000_0001.0001_e9801713934c92a6\VTMLive.exe

using VTMLive.Data.Reader;

namespace VTMLive.Data
{
  internal class Ets2Truck : IEts2Truck
  {
    private readonly Box<Ets2TelemetryStructure> _rawData;

    public Ets2Truck(Box<Ets2TelemetryStructure> rawData)
    {
      this._rawData = rawData;
    }

    public string Id
    {
      get
      {
        return Ets2TelemetryData.BytesToString(this._rawData.Struct.truckMakeId);
      }
    }

    public string Make
    {
      get
      {
        return Ets2TelemetryData.BytesToString(this._rawData.Struct.truckMake);
      }
    }

    public string Model
    {
      get
      {
        return Ets2TelemetryData.BytesToString(this._rawData.Struct.truckModel);
      }
    }

    public float Speed
    {
      get
      {
        return this._rawData.Struct.speed * 3.6f;
      }
    }

    public float CruiseControlSpeed
    {
      get
      {
        return this._rawData.Struct.cruiseControlSpeed * 3.6f;
      }
    }

    public bool CruiseControlOn
    {
      get
      {
        return (uint) this._rawData.Struct.cruiseControl > 0U;
      }
    }

    public float Odometer
    {
      get
      {
        return this._rawData.Struct.truckOdometer;
      }
    }

    public int Gear
    {
      get
      {
        return this._rawData.Struct.gear;
      }
    }

    public int DisplayedGear
    {
      get
      {
        return this._rawData.Struct.displayedGear;
      }
    }

    public int ForwardGears
    {
      get
      {
        return this._rawData.Struct.gearsForward;
      }
    }

    public int ReverseGears
    {
      get
      {
        return this._rawData.Struct.gearsReverse;
      }
    }

    public string ShifterType
    {
      get
      {
        return Ets2TelemetryData.BytesToString(this._rawData.Struct.shifterType);
      }
    }

    public float EngineRpm
    {
      get
      {
        return this._rawData.Struct.engineRpm;
      }
    }

    public float EngineRpmMax
    {
      get
      {
        return this._rawData.Struct.engineRpmMax;
      }
    }

    public float Fuel
    {
      get
      {
        return this._rawData.Struct.fuel;
      }
    }

    public float FuelCapacity
    {
      get
      {
        return this._rawData.Struct.fuelCapacity;
      }
    }

    public float FuelAverageConsumption
    {
      get
      {
        return this._rawData.Struct.fuelAvgConsumption;
      }
    }

    public float FuelWarningFactor
    {
      get
      {
        return this._rawData.Struct.fuelWarningFactor;
      }
    }

    public bool FuelWarningOn
    {
      get
      {
        return (uint) this._rawData.Struct.fuelWarning > 0U;
      }
    }

    public float WearEngine
    {
      get
      {
        return this._rawData.Struct.wearEngine;
      }
    }

    public float WearTransmission
    {
      get
      {
        return this._rawData.Struct.wearTransmission;
      }
    }

    public float WearCabin
    {
      get
      {
        return this._rawData.Struct.wearCabin;
      }
    }

    public float WearChassis
    {
      get
      {
        return this._rawData.Struct.wearChassis;
      }
    }

    public float WearWheels
    {
      get
      {
        return this._rawData.Struct.wearWheels;
      }
    }

    public float UserSteer
    {
      get
      {
        return this._rawData.Struct.userSteer;
      }
    }

    public float UserThrottle
    {
      get
      {
        return this._rawData.Struct.userThrottle;
      }
    }

    public float UserBrake
    {
      get
      {
        return this._rawData.Struct.userBrake;
      }
    }

    public float UserClutch
    {
      get
      {
        return this._rawData.Struct.userClutch;
      }
    }

    public float GameSteer
    {
      get
      {
        return this._rawData.Struct.gameSteer;
      }
    }

    public float GameThrottle
    {
      get
      {
        return this._rawData.Struct.gameThrottle;
      }
    }

    public float GameBrake
    {
      get
      {
        return this._rawData.Struct.gameBrake;
      }
    }

    public float GameClutch
    {
      get
      {
        return this._rawData.Struct.gameClutch;
      }
    }

    public int ShifterSlot
    {
      get
      {
        return this._rawData.Struct.shifterSlot;
      }
    }

    public bool EngineOn
    {
      get
      {
        return (uint) this._rawData.Struct.engineEnabled > 0U;
      }
    }

    public bool ElectricOn
    {
      get
      {
        return (uint) this._rawData.Struct.electricEnabled > 0U;
      }
    }

    public bool WipersOn
    {
      get
      {
        return (uint) this._rawData.Struct.wipers > 0U;
      }
    }

    public int RetarderBrake
    {
      get
      {
        return this._rawData.Struct.retarderBrake;
      }
    }

    public int RetarderStepCount
    {
      get
      {
        return (int) this._rawData.Struct.retarderStepCount;
      }
    }

    public bool ParkBrakeOn
    {
      get
      {
        return (uint) this._rawData.Struct.parkBrake > 0U;
      }
    }

    public bool MotorBrakeOn
    {
      get
      {
        return (uint) this._rawData.Struct.motorBrake > 0U;
      }
    }

    public float BrakeTemperature
    {
      get
      {
        return this._rawData.Struct.brakeTemperature;
      }
    }

    public float Adblue
    {
      get
      {
        return this._rawData.Struct.adblue;
      }
    }

    public float AdblueCapacity
    {
      get
      {
        return this._rawData.Struct.adblueCapacity;
      }
    }

    public float AdblueAverageConsumption
    {
      get
      {
        return this._rawData.Struct.adblueConsumption;
      }
    }

    public bool AdblueWarningOn
    {
      get
      {
        return (uint) this._rawData.Struct.adblueWarning > 0U;
      }
    }

    public float AirPressure
    {
      get
      {
        return this._rawData.Struct.airPressure;
      }
    }

    public bool AirPressureWarningOn
    {
      get
      {
        return (uint) this._rawData.Struct.airPressureWarning > 0U;
      }
    }

    public float AirPressureWarningValue
    {
      get
      {
        return this._rawData.Struct.airPressureWarningValue;
      }
    }

    public bool AirPressureEmergencyOn
    {
      get
      {
        return (uint) this._rawData.Struct.airPressureEmergency > 0U;
      }
    }

    public float AirPressureEmergencyValue
    {
      get
      {
        return this._rawData.Struct.airPressureEmergencyValue;
      }
    }

    public float OilTemperature
    {
      get
      {
        return this._rawData.Struct.oilTemperature;
      }
    }

    public float OilPressure
    {
      get
      {
        return this._rawData.Struct.oilPressure;
      }
    }

    public bool OilPressureWarningOn
    {
      get
      {
        return (uint) this._rawData.Struct.oilPressureWarning > 0U;
      }
    }

    public float OilPressureWarningValue
    {
      get
      {
        return this._rawData.Struct.oilPressureWarningValue;
      }
    }

    public float WaterTemperature
    {
      get
      {
        return this._rawData.Struct.waterTemperature;
      }
    }

    public bool WaterTemperatureWarningOn
    {
      get
      {
        return (uint) this._rawData.Struct.waterTemperatureWarning > 0U;
      }
    }

    public float WaterTemperatureWarningValue
    {
      get
      {
        return this._rawData.Struct.waterTemperatureWarningValue;
      }
    }

    public float BatteryVoltage
    {
      get
      {
        return this._rawData.Struct.batteryVoltage;
      }
    }

    public bool BatteryVoltageWarningOn
    {
      get
      {
        return (uint) this._rawData.Struct.batteryVoltageWarning > 0U;
      }
    }

    public float BatteryVoltageWarningValue
    {
      get
      {
        return this._rawData.Struct.batteryVoltageWarningValue;
      }
    }

    public float LightsDashboardValue
    {
      get
      {
        return this._rawData.Struct.lightsDashboard;
      }
    }

    public bool LightsDashboardOn
    {
      get
      {
        return (double) this._rawData.Struct.lightsDashboard > 0.0;
      }
    }

    public bool BlinkerLeftActive
    {
      get
      {
        return (uint) this._rawData.Struct.blinkerLeftActive > 0U;
      }
    }

    public bool BlinkerRightActive
    {
      get
      {
        return (uint) this._rawData.Struct.blinkerRightActive > 0U;
      }
    }

    public bool BlinkerLeftOn
    {
      get
      {
        return (uint) this._rawData.Struct.blinkerLeftOn > 0U;
      }
    }

    public bool BlinkerRightOn
    {
      get
      {
        return (uint) this._rawData.Struct.blinkerRightOn > 0U;
      }
    }

    public bool LightsParkingOn
    {
      get
      {
        return (uint) this._rawData.Struct.lightsParking > 0U;
      }
    }

    public bool LightsBeamLowOn
    {
      get
      {
        return (uint) this._rawData.Struct.lightsBeamLow > 0U;
      }
    }

    public bool LightsBeamHighOn
    {
      get
      {
        return (uint) this._rawData.Struct.lightsBeamHigh > 0U;
      }
    }

    public bool LightsAuxFrontOn
    {
      get
      {
        return this._rawData.Struct.lightsAuxFront > 0U;
      }
    }

    public bool LightsAuxRoofOn
    {
      get
      {
        return this._rawData.Struct.lightsAuxRoof > 0U;
      }
    }

    public bool LightsBeaconOn
    {
      get
      {
        return (uint) this._rawData.Struct.lightsBeacon > 0U;
      }
    }

    public bool LightsBrakeOn
    {
      get
      {
        return (uint) this._rawData.Struct.lightsBrake > 0U;
      }
    }

    public bool LightsReverseOn
    {
      get
      {
        return (uint) this._rawData.Struct.lightsReverse > 0U;
      }
    }

    public IEts2Placement Placement
    {
      get
      {
        return (IEts2Placement) new Ets2Placement(this._rawData.Struct.coordinateX, this._rawData.Struct.coordinateY, this._rawData.Struct.coordinateZ, this._rawData.Struct.rotationX, this._rawData.Struct.rotationY, this._rawData.Struct.rotationZ);
      }
    }

    public IEts2Vector Acceleration
    {
      get
      {
        return (IEts2Vector) new Ets2Vector(this._rawData.Struct.accelerationX, this._rawData.Struct.accelerationY, this._rawData.Struct.accelerationZ);
      }
    }

    public IEts2Vector Head
    {
      get
      {
        return (IEts2Vector) new Ets2Vector(this._rawData.Struct.headPositionX, this._rawData.Struct.headPositionY, this._rawData.Struct.headPositionZ);
      }
    }

    public IEts2Vector Cabin
    {
      get
      {
        return (IEts2Vector) new Ets2Vector(this._rawData.Struct.cabinPositionX, this._rawData.Struct.cabinPositionY, this._rawData.Struct.cabinPositionZ);
      }
    }

    public IEts2Vector Hook
    {
      get
      {
        return (IEts2Vector) new Ets2Vector(this._rawData.Struct.hookPositionX, this._rawData.Struct.hookPositionY, this._rawData.Struct.hookPositionZ);
      }
    }
  }
}
