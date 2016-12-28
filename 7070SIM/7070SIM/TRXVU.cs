using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7070SIM
{
    class TRXVU
    {
        private int watchdog;

        private byte[] beacon;

        public int Watchdog
        {
            get { return watchdog; }
            set { watchdog = value; }
        }

        public TRXVU()
        {

        }

        /// <summary>
        /// Performs a reset of the internal watchdog.
        /// </summary>
        public void watchdogReset()
        {

        }

        /// <summary>
        /// Performs a software reset of the transmitter processor.
        /// </summary>
        public void softwareReset()
        {

        }

        /// <summary>
        /// Power cycles the full board (transmitter and receiver will be both reset). 
        /// </summary>
        public void hardwareReset()
        {

        }

        /// <summary>
        /// Adds a frame (AX.25 UI or HDLC frame, according to [AD01]) to the frame buffer of the
        ///transmitter. If the radio mode is AX.25 (as specified in [AD01]), the AX.25 frame will contain
        ///the default callsigns as they are set in the controller at the time this command is received.
        ///This command will disable any beacon that is currently being transmitted by the transceiver.
        ///The frame will not be added to the frame buffer if:
        ///      The frame buffer is full
        ///      The content size is 0 bytes
        ///      The content size is larger than the maximum size (specified in [AD01])
        /// </summary>
        /// <param name="frame">
        /// [001 - N] n/a, binary
        ///Contents of the AX.25 frame's INFO field or HDLC payload field. The contents have a
        ///minimum size of 1 byte and a maximum size specified in [AD01] (default value is 235 bytes).
        /// </param>
        /// <returns>
        /// [000 - 000] xxxxxxxx
        ///Number of remaining available 'slots' in the transmission buffer of the transmitter after this
        ///frame has been added. The minimum value of this response is 0 (meaning the buffer is full)
        ///and the maximum value of this response is the transmission frame buffer size as specified in
        ///the device configuration (This configuration is defined in the Test Report document delivered
        ///with this manual). If the response has a value of 255 (or 0xFF in hexadecimal) then the frame
        ///was not added to the buffer.
        /// </returns>
        public byte[] sendFrame(byte[] Frame)
        {
            return null;
        }

        /// <summary>
        /// Adds an AX.25 UI frame to the frame buffer of the transmitter. This AX.25 frame will contain
        /// the callsigns as specified in the command, ignoring the callsigns set in the receiver. This
        /// command will disable any beacon that is currently being transmitted by the transceiver. The
        /// AX.25 frame will not be added to the frame buffer if:
        ///      The frame buffer is full
        ///      The content size is 0 bytes
        ///      The content size is larger than the maximum size (specified in [AD01])
        /// This command is only available if the radio is set in AX.25 mode in [AD01].
        /// </summary>
        /// <param name="frame">
        /// [001 - 007] n/a, ASCII & binary:
        /// AX.25 TO callsign to be used when transmitting this AX.25 frame. The first 6 bytes should be
        ///ASCII characters, while the 7th byte should be a number (binary encoded between 0 and 15,
        ///usually 0).
        ///
        /// [008 - 014] n/a, ASCII & binary:
        /// AX.25 FROM callsign to be used when transmitting this AX.25 frame. The first 6 bytes should
        ///be ASCII characters, while the 7th byte should be a number (binary encoded between 0 and 15, usually 0).
        /// 
        /// [015 - N] n/a, binary:
        /// Contents of the AX.25 frame's INFO field. The contents have a minimum size of 1 byte and a
        ///maximum size specified in [AD01] (default value is 235 bytes).
        /// </param>
        /// <returns>
        /// Number of remaining available 'slots' in the transmission buffer of the ITC after this frame has
        ///been added. The minimum value of this response is 0 (meaning the buffer is full) and the
        ///maximum value of this response is the transmission frame buffer size as specified in the
        ///device configuration (This configuration is defined in the Test Report document delivered with
        ///this manual). If the response has a value of 255 (or 0xFF in hexadecimal) then the frame was
        ///not added to the buffer.
        /// </returns>
        public byte[] SendFrameWithCS(byte[] Frame)
        {

            return null;
        }

        /// <summary>
        /// Sets the transceiver to autonomously repeat transmission of a beacon message contained in
        /// an AX.25 UI frame or HDLC frame (mode is specified in [AD01]. The AX.25 frame will contain
        /// the default callsigns as they are set in the transmitter at the time this command is received.
        /// This command will remove any frame that is stored in the frame buffer waiting for
        /// transmission. The first transmission of the beacon message will take place when this
        /// command is received. If the transceiver is not in nominal telemetry mode, this command will
        /// have no effect.
        /// </summary>
        /// <param name="Beacon">
        /// [001 - 002] xxxxxxxx 0000xxxx
        /// Repeat interval of the beacon in seconds. This is the interval between the starts of two
        /// transmissions of the beacon. This interval has a minimum value of 0 and a maximum value of
        /// 3000. If an interval of more than 3000 seconds is specified, the interval will automatically be
        /// set to 3000. The least significant byte should be sent first (little endian).
        /// [003 – N] n/a, binary
        /// Contents of the AX.25 frame's INFO field. The contents have a minimum size of 1 byte and a
        /// maximum size specified in [AD01] (default value is 235 bytes).
        /// </param>
        public void SetBeacon(byte[] Beacon)
        {

        }

        /// <summary>
        /// Sets the transceiver to autonomously repeat transmission of a beacon message contained in
        /// an AX.25 UI frame. This AX.25 frame will contain the callsigns as specified in the command,
        /// ignoring the callsigns set in the receiver. This command will remove any AX.25 frames that
        /// are stored in the frame buffer waiting for transmission. The first transmission of the beacon
        /// message will take place when this command is received. If the transceiver is not in nominal
        /// telemetry mode, this command will have no effect. This command is only available if the radio
        ///is set in AX.25 mode in [AD01].
        /// </summary>
        /// <param name="Beacon">
        /// [001 - 002] xxxxxxxx 0000xxxx:
        /// Repeat interval of the beacon in seconds. This is the interval between the starts of two
        /// transmissions of the beacon. This interval has a minimum value of 0 and a maximum value of
        /// 3000. If an interval of more than 3000 seconds is specified, the interval will automatically be
        /// set to 3000.
        /// 
        /// [003 - 009] n/a, ASCII & binary:
        /// /// AX.25 TO callsign to be used when transmitting this AX.25 frame. The first 6 bytes should be
        /// ASCII characters, while the 7th byte should be a number (binary encoded between 0 and 15,
        /// usually 0).
        /// 
        /// [010 - 016] n/a, ASCII & binary:
        /// AX.25 FROM callsign to be used when transmitting this AX.25 frame. The first 6 bytes should
        /// be ASCII characters, while the 7th byte should be a number (binary encoded between 0 and
        /// 15, usually 0).
        /// 
        /// [017 – N] n/a, binary:
        /// Contents of the AX.25 frame's INFO field. The content has a minimum size of 1 byte and a
        /// maximum size specified in [AD01] (default value is 235 bytes).

        /// </param>
        public void SetBeaconWithCS(byte[] Beacon)
        {

        }

        /// <summary>
        /// Clears any beacon that is currently set in the transceiver. If a beacon transmission is currently
        ///in progress, this transmission will be completed.
        /// </summary>
        public void clearBeacon()
        {


        }

    }
}
